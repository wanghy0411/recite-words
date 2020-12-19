/*==============================================================*/
/* DBMS name:      PostgreSQL 9.x                               */
/* Created on:     2020/12/19 10:13:53                          */
/*==============================================================*/


/*==============================================================*/
/* Table: dictionary                                            */
/*==============================================================*/
create table dictionary (
   id                   int8                 not null,
   name                 varchar(1024)        not null,
   publisher            varchar(3072)        null,
   valid_flag           char(1)              not null,
   public_flag          char(1)              not null,
   constraint dictionary_pkey primary key (id)
);

comment on table dictionary is
'词典';

comment on column dictionary.id is
'id';

comment on column dictionary.name is
'词典名称';

comment on column dictionary.publisher is
'出版社';

comment on column dictionary.valid_flag is
'有效标志';

comment on column dictionary.public_flag is
'公用标志';

/*==============================================================*/
/* Table: exercise                                              */
/*==============================================================*/
create table exercise (
   id                   int8                 not null,
   user_id              int8                 not null,
   exercise_time        int8                 not null,
   score                int4                 null,
   comment              varchar(3072)        null,
   constraint exercise_pkey primary key (id)
);

comment on table exercise is
'测验';

comment on column exercise.id is
'id';

comment on column exercise.user_id is
'用户id';

comment on column exercise.exercise_time is
'测验时间';

comment on column exercise.score is
'分数';

comment on column exercise.comment is
'备注';

/*==============================================================*/
/* Index: i_exercise_exercise_time                              */
/*==============================================================*/
create  index i_exercise_exercise_time on exercise (
exercise_time
);

/*==============================================================*/
/* Index: i_exercise_user_id                                    */
/*==============================================================*/
create  index i_exercise_user_id on exercise (
user_id
);

/*==============================================================*/
/* Table: exercise_words                                        */
/*==============================================================*/
create table exercise_words (
   id                   int8                 not null,
   exercise_id          int8                 not null,
   vocabulary_id        int8                 not null,
   line_number          int4                 not null,
   correct              int4                 null,
   constraint exercise_words_pkey primary key (id)
);

comment on table exercise_words is
'测验单词列表';

comment on column exercise_words.id is
'id';

comment on column exercise_words.exercise_id is
'测验id';

comment on column exercise_words.vocabulary_id is
'词汇id';

comment on column exercise_words.line_number is
'行号';

comment on column exercise_words.correct is
'练习对错(1正确0错误)';

/*==============================================================*/
/* Index: i_exercise_words_exercise_id                          */
/*==============================================================*/
create  index i_exercise_words_exercise_id on exercise_words (
exercise_id
);

/*==============================================================*/
/* Table: recite                                                */
/*==============================================================*/
create table recite (
   id                   int8                 not null,
   user_id              int8                 not null,
   recite_time          int8                 not null,
   comment              varchar(3072)        null,
   constraint recite_pkey primary key (id)
);

comment on table recite is
'背单词';

comment on column recite.id is
'id';

comment on column recite.user_id is
'用户id';

comment on column recite.recite_time is
'背诵时间';

comment on column recite.comment is
'备注';

/*==============================================================*/
/* Index: i_recite_recite_time                                  */
/*==============================================================*/
create  index i_recite_recite_time on recite (
recite_time
);

/*==============================================================*/
/* Index: i_recite_user_id                                      */
/*==============================================================*/
create  index i_recite_user_id on recite (
user_id
);

/*==============================================================*/
/* Table: recite_words                                          */
/*==============================================================*/
create table recite_words (
   id                   int8                 not null,
   recite_id            int8                 not null,
   words_id             int8                 not null,
   constraint recite_words_pkey primary key (id)
);

comment on table recite_words is
'单词列表';

comment on column recite_words.id is
'id';

comment on column recite_words.recite_id is
'recite_id';

comment on column recite_words.words_id is
'words_id';

/*==============================================================*/
/* Index: i_recite_words_recite_id                              */
/*==============================================================*/
create  index i_recite_words_recite_id on recite_words (
recite_id
);

/*==============================================================*/
/* Table: review                                                */
/*==============================================================*/
create table review (
   id                   int8                 not null,
   user_id              int8                 not null,
   review_time          int8                 not null,
   comment              varchar(3072)        null,
   constraint review_pkey primary key (id)
);

comment on table review is
'复习';

comment on column review.id is
'id';

comment on column review.user_id is
'用户id';

comment on column review.review_time is
'复习时间';

comment on column review.comment is
'备注';

/*==============================================================*/
/* Index: i_review_review_time                                  */
/*==============================================================*/
create  index i_review_review_time on review (
review_time
);

/*==============================================================*/
/* Index: i_review_user_id                                      */
/*==============================================================*/
create  index i_review_user_id on review (
user_id
);

/*==============================================================*/
/* Table: review_words                                          */
/*==============================================================*/
create table review_words (
   id                   int8                 not null,
   review_id            int8                 not null,
   words_id             int8                 not null,
   constraint review_words_pkey primary key (id)
);

comment on table review_words is
'复习单词列表';

comment on column review_words.id is
'id';

comment on column review_words.review_id is
'review_id';

comment on column review_words.words_id is
'words_id';

/*==============================================================*/
/* Index: i_review_words_review_id                              */
/*==============================================================*/
create  index i_review_words_review_id on review_words (
review_id
);

/*==============================================================*/
/* Table: user_dictionary                                       */
/*==============================================================*/
create table user_dictionary (
   id                   int8                 not null,
   user_id              int8                 null,
   dictionary_id        int8                 null,
   constraint pk_user_dictionary primary key (id)
);

comment on table user_dictionary is
'用户和字典对应关系';

comment on column user_dictionary.user_id is
'用户id';

comment on column user_dictionary.dictionary_id is
'字典id';

/*==============================================================*/
/* Index: i_user_dictionary_unique                              */
/*==============================================================*/
create unique index i_user_dictionary_unique on user_dictionary (
user_id,
dictionary_id
);

/*==============================================================*/
/* Table: user_info                                             */
/*==============================================================*/
create table user_info (
   id                   int8                 not null,
   nick                 varchar(1024)        not null,
   name                 varchar(1024)        not null,
   admin_flag           int4                 not null,
   constraint user_info_pkey primary key (id)
);

comment on table user_info is
'用户';

comment on column user_info.id is
'id';

comment on column user_info.nick is
'用户昵称';

comment on column user_info.name is
'用户姓名';

comment on column user_info.admin_flag is
'管理员标志';

/*==============================================================*/
/* Index: i_user_info_nick                                      */
/*==============================================================*/
create unique index i_user_info_nick on user_info (
nick
);

/*==============================================================*/
/* Table: user_password                                         */
/*==============================================================*/
create table user_password (
   id                   int8                 not null,
   password             varchar(1024)        null
);

comment on table user_password is
'用户密码';

/*==============================================================*/
/* Table: vocabulary                                            */
/*==============================================================*/
create table vocabulary (
   id                   int8                 not null,
   user_id              int8                 not null,
   words_id             int8                 not null,
   review_time          int4                 not null,
   review_schedule_time1 int8                 not null,
   review_schedule_time2 int8                 not null,
   review_schedule_time3 int8                 not null,
   review_schedule_time4 int8                 not null,
   constraint vocabulary_pkey primary key (id)
);

comment on table vocabulary is
'词汇表';

comment on column vocabulary.id is
'id';

comment on column vocabulary.user_id is
'用户id';

comment on column vocabulary.words_id is
'单词id';

comment on column vocabulary.review_time is
'已复习次数';

comment on column vocabulary.review_schedule_time1 is
'复习时间1';

comment on column vocabulary.review_schedule_time2 is
'复习时间2';

comment on column vocabulary.review_schedule_time3 is
'复习时间3';

comment on column vocabulary.review_schedule_time4 is
'复习时间4';

/*==============================================================*/
/* Index: i_vocabulary_user_id                                  */
/*==============================================================*/
create  index i_vocabulary_user_id on vocabulary (
user_id
);

/*==============================================================*/
/* Index: i_vocabulary_words_id                                 */
/*==============================================================*/
create  index i_vocabulary_words_id on vocabulary (
words_id
);

/*==============================================================*/
/* Table: words                                                 */
/*==============================================================*/
create table words (
   id                   int8                 not null,
   dictionary_id        int8                 not null,
   spelling             varchar(1024)        not null,
   pronunciation        varchar(1024)        null,
   explanation          text                 null,
   constraint words_pkey primary key (id)
);

comment on table words is
'单词表';

comment on column words.id is
'id';

comment on column words.dictionary_id is
'词典id';

comment on column words.spelling is
'拼写';

comment on column words.pronunciation is
'发音';

comment on column words.explanation is
'释义';

/*==============================================================*/
/* Index: i_words_spelling                                      */
/*==============================================================*/
create  index i_words_spelling on words (
spelling
);

