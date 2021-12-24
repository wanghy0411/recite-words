insert into vocabulary
select id, 127373929833643012, id, 4, 1639723986261, 1640242386261, 1642229586261, 1647413586261 from words
where dictionary_id in (select dictionary_id from user_dictionary where user_id = 127373929833643012)
  and id not in (select words_id from vocabulary where user_id = 127373929833643012)
;


--建立一个新的exercise

insert into exercise_words
select rn + 261535874396906188 as id, 261535874199773849 as exercise_id, id as vocabulary_id, rn + 50 as line_number, null
from (
         select row_number() over() as rn, id
         from vocabulary
         where user_id = 127373929833643012
           and id not in (select vocabulary_id from exercise_words)
           and words_id in (select id from words where dictionary_id = 229558995285248409)
     ) tmp