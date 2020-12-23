package org.noodle.service.exercise;

import org.noodle.bean.exercise.ExerciseWordsDto;
import org.noodle.bean.exercise.ExerciseWordsRequest;
import org.noodle.beans.NoodleException;
import org.noodle.orm.mapper.ExerciseWordsMapper;
import org.noodle.orm.mapper.VocabularyMapper;
import org.noodle.orm.mapper.WordsMapper;
import org.noodle.orm.model.ExerciseWords;
import org.noodle.orm.model.Vocabulary;
import org.noodle.orm.model.Words;
import org.noodle.service.NoodlePostService;
import org.springframework.stereotype.Service;

import javax.annotation.Resource;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;

/**
 * 测验记录中单词列表查询服务
 * @author wanghy
 */
@Service("exercise.words")
public class ExerciseWordsService implements NoodlePostService<ExerciseWordsRequest, List<ExerciseWordsDto>> {
    @Resource
    private ExerciseWordsMapper exerciseWordsMapper;

    @Resource
    private WordsMapper wordsMapper;

    @Resource
    private VocabularyMapper vocabularyMapper;

    @Override
    public Class<ExerciseWordsRequest> getRequestClass() {
        return ExerciseWordsRequest.class;
    }

    @Override
    public List<ExerciseWordsDto> execute(ExerciseWordsRequest request) throws NoodleException {
        List<ExerciseWords> exerciseWordsList = exerciseWordsMapper.selectByExerciseId(request.getExerciseId());
        return exerciseWordsList.parallelStream()
                .sorted(Comparator.comparing(ExerciseWords::getId))
                .map(this::convertToDto)
                .collect(Collectors.toList());
    }

    private ExerciseWordsDto convertToDto(ExerciseWords exerciseWords) {
        Vocabulary vocabulary = vocabularyMapper.selectByPrimaryKey(exerciseWords.getVocabularyId());
        Words words = wordsMapper.selectByPrimaryKey(vocabulary.getWordsId());

        ExerciseWordsDto dto = new ExerciseWordsDto();
        dto.setId(exerciseWords.getId());
        dto.setWordsId(vocabulary.getWordsId());
        dto.setExerciseId(exerciseWords.getExerciseId());
        dto.setSpelling(words.getSpelling());
        dto.setPronunciation(words.getPronunciation());
        dto.setExplanation(words.getExplanation());
        dto.setLineNumber(exerciseWords.getLineNumber());
        dto.setCorrect(exerciseWords.getCorrect());

        return dto;
    }
}
