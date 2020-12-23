package org.noodle.service.exercise;

import com.github.pagehelper.PageHelper;
import org.noodle.bean.exercise.ExerciseVocabularyDto;
import org.noodle.bean.exercise.ExerciseVocabularyListRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.VocabularyMapper;
import org.noodle.orm.mapper.WordsMapper;
import org.noodle.orm.model.Vocabulary;
import org.noodle.orm.model.Words;
import org.noodle.service.NoodlePostService;
import org.springframework.stereotype.Service;

import javax.annotation.Resource;
import java.util.List;
import java.util.stream.Collectors;

/**
 * 个人应测验词汇查询服务
 * @author wanghy
 */
@Service("exercise.vocabulary")
public class ExerciseVocabularyListService implements NoodlePostService<ExerciseVocabularyListRequest, List<ExerciseVocabularyDto>> {
    @Resource
    private VocabularyMapper vocabularyMapper;

    @Resource
    private WordsMapper wordsMapper;

    @Override
    public Class<ExerciseVocabularyListRequest> getRequestClass() {
        return ExerciseVocabularyListRequest.class;
    }

    @Override
    public List<ExerciseVocabularyDto> execute(ExerciseVocabularyListRequest request) throws NoodleException {
        int pageSize = request.getPageSize()==null?500: request.getPageSize();
        int pageNum = request.getPageNum()==null?1:request.getPageNum();

        PageHelper.startPage(pageNum, pageSize, false);
        List<Vocabulary> vocabularyList = vocabularyMapper.selectNeedExerciseByUser(request.getUserId());

        return vocabularyList.parallelStream()
                .map(this::convertToDto)
                .collect(Collectors.toList());
    }

    private ExerciseVocabularyDto convertToDto(Vocabulary vocabulary) {
        ExerciseVocabularyDto dto = new ExerciseVocabularyDto();
        dto.setVocabularyId(vocabulary.getId());

        Words words = wordsMapper.selectByPrimaryKey(vocabulary.getWordsId());
        dto.setSpelling(words.getSpelling());
        dto.setPronunciation(words.getPronunciation());
        dto.setExplanation(words.getExplanation());

        return dto;
    }
}
