package org.noodle.service.review;

import com.github.pagehelper.PageHelper;
import org.noodle.bean.review.ReviewVocabularyDto;
import org.noodle.bean.review.ReviewVocabularyListRequest;
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
 * 个人应复习词汇查询服务
 * @author wanghy
 */
@Service("review.vocabulary")
public class ReviewVocabularyListService implements NoodlePostService<ReviewVocabularyListRequest, List<ReviewVocabularyDto>> {
    @Resource
    private VocabularyMapper vocabularyMapper;

    @Resource
    private WordsMapper wordsMapper;

    @Override
    public Class<ReviewVocabularyListRequest> getRequestClass() {
        return ReviewVocabularyListRequest.class;
    }

    @Override
    public List<ReviewVocabularyDto> execute(ReviewVocabularyListRequest request) throws NoodleException {
        int pageSize = request.getPageSize()==null?500: request.getPageSize();
        int pageNum = request.getPageNum()==null?1:request.getPageNum();

        PageHelper.startPage(pageNum, pageSize, false);
        List<Vocabulary> vocabularyList = vocabularyMapper.selectNeedReviewByUser(request.getUserId(), System.currentTimeMillis());

        return vocabularyList.parallelStream()
                .map(this::convertToDto)
                .collect(Collectors.toList());
    }

    private ReviewVocabularyDto convertToDto(Vocabulary vocabulary) {
        ReviewVocabularyDto dto = new ReviewVocabularyDto();
        dto.setVocabularyId(vocabulary.getId());

        Words words = wordsMapper.selectByPrimaryKey(vocabulary.getWordsId());
        dto.setSpelling(words.getSpelling());
        dto.setPronunciation(words.getPronunciation());
        dto.setExplanation(words.getExplanation());

        return dto;
    }
}
