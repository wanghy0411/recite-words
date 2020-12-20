package org.noodle.service.recite;

import org.noodle.bean.recite.words.ReciteWordsDto;
import org.noodle.bean.recite.words.ReciteWordsRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.ReciteWordsMapper;
import org.noodle.orm.mapper.WordsMapper;
import org.noodle.orm.model.ReciteWords;
import org.noodle.orm.model.Words;
import org.noodle.service.NoodlePostService;
import org.springframework.stereotype.Service;

import javax.annotation.Resource;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;

/**
 * 背诵记录中单词列表查询服务
 * @author wanghy
 */
@Service("recite.words")
public class ReciteWordsService implements NoodlePostService<ReciteWordsRequest, List<ReciteWordsDto>> {
    @Resource
    private ReciteWordsMapper reciteWordsMapper;

    @Resource
    private WordsMapper wordsMapper;

    @Override
    public Class<ReciteWordsRequest> getRequestClass() {
        return ReciteWordsRequest.class;
    }

    @Override
    public List<ReciteWordsDto> execute(ReciteWordsRequest request) throws NoodleException {
        List<ReciteWords> reciteWordsList = reciteWordsMapper.selectByReciteId(request.getReciteId());
        return reciteWordsList.parallelStream()
                .sorted(Comparator.comparing(ReciteWords::getId))
                .map(this::convertToDto)
                .collect(Collectors.toList());
    }

    private ReciteWordsDto convertToDto(ReciteWords reciteWords) {
        Words words = wordsMapper.selectByPrimaryKey(reciteWords.getWordsId());

        ReciteWordsDto dto = new ReciteWordsDto();
        dto.setId(reciteWords.getId());
        dto.setWordsId(reciteWords.getWordsId());
        dto.setReciteId(reciteWords.getReciteId());
        dto.setSpelling(words.getSpelling());
        dto.setPronunciation(words.getPronunciation());
        dto.setExplanation(words.getExplanation());

        return dto;
    }
}
