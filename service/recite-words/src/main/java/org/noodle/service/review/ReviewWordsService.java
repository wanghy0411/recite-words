package org.noodle.service.review;

import org.noodle.bean.review.ReviewWordsDto;
import org.noodle.bean.review.ReviewWordsRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.ReviewWordsMapper;
import org.noodle.orm.mapper.WordsMapper;
import org.noodle.orm.model.ReviewWords;
import org.noodle.orm.model.Words;
import org.noodle.service.NoodlePostService;
import org.springframework.stereotype.Service;

import javax.annotation.Resource;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;

/**
 * 复习记录中单词列表查询服务
 * @author wanghy
 */
@Service("review.words")
public class ReviewWordsService implements NoodlePostService<ReviewWordsRequest, List<ReviewWordsDto>> {
    @Resource
    private ReviewWordsMapper reviewWordsMapper;

    @Resource
    private WordsMapper wordsMapper;

    @Override
    public Class<ReviewWordsRequest> getRequestClass() {
        return ReviewWordsRequest.class;
    }

    @Override
    public List<ReviewWordsDto> execute(ReviewWordsRequest request) throws NoodleException {
        List<ReviewWords> reviewWordsList = reviewWordsMapper.selectByReviewId(request.getReviewId());
        return reviewWordsList.parallelStream()
                .sorted(Comparator.comparing(ReviewWords::getId))
                .map(this::convertToDto)
                .collect(Collectors.toList());
    }

    private ReviewWordsDto convertToDto(ReviewWords reviewWords) {
        Words words = wordsMapper.selectByPrimaryKey(reviewWords.getWordsId());

        ReviewWordsDto dto = new ReviewWordsDto();
        dto.setId(reviewWords.getId());
        dto.setWordsId(reviewWords.getWordsId());
        dto.setReviewId(reviewWords.getReviewId());
        dto.setSpelling(words.getSpelling());
        dto.setPronunciation(words.getPronunciation());
        dto.setExplanation(words.getExplanation());

        return dto;
    }
}
