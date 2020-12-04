
CREATE TABLE dictionary (
  id int8 NOT NULL,
  name varchar(1024)  NOT NULL,
  publisher varchar(3072) ,
  valid_flag char(1)  NOT NULL,
  public_flag char(1)  NOT NULL
)
;
COMMENT ON COLUMN dictionary.id IS 'id';
COMMENT ON COLUMN dictionary.name IS '词典名称';
COMMENT ON COLUMN dictionary.publisher IS '出版社';
COMMENT ON COLUMN dictionary.valid_flag IS '有效标志';
COMMENT ON COLUMN dictionary.public_flag IS '公用标志';
COMMENT ON TABLE dictionary IS '词典';

-- ----------------------------
-- Table structure for exercise
-- ----------------------------
CREATE TABLE exercise (
  id int8 NOT NULL,
  user_id int8 NOT NULL,
  exercise_time int8 NOT NULL,
  score int4,
  comment varchar(3072) 
)
;
COMMENT ON COLUMN exercise.id IS 'id';
COMMENT ON COLUMN exercise.user_id IS '用户id';
COMMENT ON COLUMN exercise.exercise_time IS '测验时间';
COMMENT ON COLUMN exercise.score IS '分数';
COMMENT ON COLUMN exercise.comment IS '备注';
COMMENT ON TABLE exercise IS '测验';

-- ----------------------------
-- Table structure for exercise_words
-- ----------------------------
CREATE TABLE exercise_words (
  id int8 NOT NULL,
  exercise_id int8 NOT NULL,
  vocabulary_id int8 NOT NULL,
  line_number int4 NOT NULL,
  correct int4
)
;
COMMENT ON COLUMN exercise_words.id IS 'id';
COMMENT ON COLUMN exercise_words.exercise_id IS '测验id';
COMMENT ON COLUMN exercise_words.vocabulary_id IS '词汇id';
COMMENT ON COLUMN exercise_words.line_number IS '行号';
COMMENT ON COLUMN exercise_words.correct IS '练习对错(1正确0错误)';
COMMENT ON TABLE exercise_words IS '测验单词列表';

-- ----------------------------
-- Table structure for recite
-- ----------------------------
CREATE TABLE recite (
  id int8 NOT NULL,
  user_id int8 NOT NULL,
  recite_time int8 NOT NULL,
  comment varchar(3072) 
)
;
COMMENT ON COLUMN recite.id IS 'id';
COMMENT ON COLUMN recite.user_id IS '用户id';
COMMENT ON COLUMN recite.recite_time IS '背诵时间';
COMMENT ON COLUMN recite.comment IS '备注';
COMMENT ON TABLE recite IS '背单词';

-- ----------------------------
-- Table structure for recite_words
-- ----------------------------
CREATE TABLE recite_words (
  id int8 NOT NULL,
  recite_id int8 NOT NULL,
  words_id int8 NOT NULL
)
;
COMMENT ON COLUMN recite_words.id IS 'id';
COMMENT ON COLUMN recite_words.recite_id IS 'recite_id';
COMMENT ON COLUMN recite_words.words_id IS 'words_id';
COMMENT ON TABLE recite_words IS '单词列表';

-- ----------------------------
-- Table structure for review
-- ----------------------------
CREATE TABLE review (
  id int8 NOT NULL,
  user_id int8 NOT NULL,
  review_time int8 NOT NULL,
  comment varchar(3072) 
)
;
COMMENT ON COLUMN review.id IS 'id';
COMMENT ON COLUMN review.user_id IS '用户id';
COMMENT ON COLUMN review.review_time IS '复习时间';
COMMENT ON COLUMN review.comment IS '备注';
COMMENT ON TABLE review IS '复习';

-- ----------------------------
-- Table structure for review_words
-- ----------------------------
CREATE TABLE review_words (
  id int8 NOT NULL,
  review_id int8 NOT NULL,
  words_id int8 NOT NULL
)
;
COMMENT ON COLUMN review_words.id IS 'id';
COMMENT ON COLUMN review_words.review_id IS 'review_id';
COMMENT ON COLUMN review_words.words_id IS 'words_id';
COMMENT ON TABLE review_words IS '复习单词列表';

-- ----------------------------
-- Table structure for user_info
-- ----------------------------
CREATE TABLE user_info (
  id int8 NOT NULL,
  nick varchar(1024)  NOT NULL,
  name varchar(1024)  NOT NULL
)
;
COMMENT ON COLUMN user_info.id IS 'id';
COMMENT ON COLUMN user_info.nick IS '用户昵称';
COMMENT ON COLUMN user_info.name IS '用户姓名';
COMMENT ON TABLE user_info IS '用户';

-- ----------------------------
-- Table structure for user_password
-- ----------------------------
CREATE TABLE "public"."user_password" (
  "id" int8 NOT NULL,
  "password" varchar(1024) COLLATE "pg_catalog"."default" NOT NULL
)
;
COMMENT ON COLUMN "public"."user_password"."id" IS '用户id';
COMMENT ON COLUMN "public"."user_password"."password" IS '密码';
COMMENT ON TABLE "public"."user_password" IS '用户密码';

-- ----------------------------
-- Table structure for vocabulary
-- ----------------------------
CREATE TABLE vocabulary (
  id int8 NOT NULL,
  user_id int8 NOT NULL,
  words_id int8 NOT NULL,
  review_time int4 NOT NULL,
  review_schedule_time1 int8 NOT NULL,
  review_schedule_time2 int8 NOT NULL,
  review_schedule_time3 int8 NOT NULL,
  review_schedule_time4 int8 NOT NULL
)
;
COMMENT ON COLUMN vocabulary.id IS 'id';
COMMENT ON COLUMN vocabulary.user_id IS '用户id';
COMMENT ON COLUMN vocabulary.words_id IS '单词id';
COMMENT ON COLUMN vocabulary.review_time IS '已复习次数';
COMMENT ON COLUMN vocabulary.review_schedule_time1 IS '复习时间1';
COMMENT ON COLUMN vocabulary.review_schedule_time2 IS '复习时间2';
COMMENT ON COLUMN vocabulary.review_schedule_time3 IS '复习时间3';
COMMENT ON COLUMN vocabulary.review_schedule_time4 IS '复习时间4';
COMMENT ON TABLE vocabulary IS '词汇表';

-- ----------------------------
-- Table structure for words
-- ----------------------------
CREATE TABLE words (
  id int8 NOT NULL,
  dictionary_id int8 NOT NULL,
  spelling varchar(1024)  NOT NULL,
  pronunciation varchar(1024) ,
  explanation text 
)
;
COMMENT ON COLUMN words.id IS 'id';
COMMENT ON COLUMN words.dictionary_id IS '词典id';
COMMENT ON COLUMN words.spelling IS '拼写';
COMMENT ON COLUMN words.pronunciation IS '发音';
COMMENT ON COLUMN words.explanation IS '释义';
COMMENT ON TABLE words IS '单词表';

-- ----------------------------
-- Primary Key structure for table dictionary
-- ----------------------------
ALTER TABLE dictionary ADD CONSTRAINT dictionary_pkey PRIMARY KEY (id);

-- ----------------------------
-- Indexes structure for table exercise
-- ----------------------------
CREATE INDEX i_exercise_exercise_time ON exercise  (
  exercise_time pg_catalog.int8_ops ASC 
);
CREATE INDEX i_exercise_user_id ON exercise  (
  user_id pg_catalog.int8_ops ASC 
);

-- ----------------------------
-- Primary Key structure for table exercise
-- ----------------------------
ALTER TABLE exercise ADD CONSTRAINT exercise_pkey PRIMARY KEY (id);

-- ----------------------------
-- Indexes structure for table exercise_words
-- ----------------------------
CREATE INDEX i_exercise_words_exercise_id ON exercise_words  (
  exercise_id pg_catalog.int8_ops ASC 
);

-- ----------------------------
-- Primary Key structure for table exercise_words
-- ----------------------------
ALTER TABLE exercise_words ADD CONSTRAINT exercise_words_pkey PRIMARY KEY (id);

-- ----------------------------
-- Indexes structure for table recite
-- ----------------------------
CREATE INDEX i_recite_recite_time ON recite  (
  recite_time pg_catalog.int8_ops ASC 
);
CREATE INDEX i_recite_user_id ON recite  (
  user_id pg_catalog.int8_ops ASC 
);

-- ----------------------------
-- Primary Key structure for table recite
-- ----------------------------
ALTER TABLE recite ADD CONSTRAINT recite_pkey PRIMARY KEY (id);

-- ----------------------------
-- Indexes structure for table recite_words
-- ----------------------------
CREATE INDEX i_recite_words_recite_id ON recite_words  (
  recite_id pg_catalog.int8_ops ASC 
);

-- ----------------------------
-- Primary Key structure for table recite_words
-- ----------------------------
ALTER TABLE recite_words ADD CONSTRAINT recite_words_pkey PRIMARY KEY (id);

-- ----------------------------
-- Indexes structure for table review
-- ----------------------------
CREATE INDEX i_review_review_time ON review  (
  review_time pg_catalog.int8_ops ASC 
);
CREATE INDEX i_review_user_id ON review  (
  user_id pg_catalog.int8_ops ASC 
);

-- ----------------------------
-- Primary Key structure for table review
-- ----------------------------
ALTER TABLE review ADD CONSTRAINT review_pkey PRIMARY KEY (id);

-- ----------------------------
-- Indexes structure for table review_words
-- ----------------------------
CREATE INDEX i_review_words_review_id ON review_words  (
  review_id pg_catalog.int8_ops ASC 
);

-- ----------------------------
-- Primary Key structure for table review_words
-- ----------------------------
ALTER TABLE review_words ADD CONSTRAINT review_words_pkey PRIMARY KEY (id);

-- ----------------------------
-- Indexes structure for table user_info
-- ----------------------------
CREATE UNIQUE INDEX i_user_info_nick ON user_info  (
  nick  pg_catalog.text_ops ASC 
);

-- ----------------------------
-- Primary Key structure for table user_info
-- ----------------------------
ALTER TABLE user_info ADD CONSTRAINT user_info_pkey PRIMARY KEY (id);

-- ----------------------------
-- Indexes structure for table vocabulary
-- ----------------------------
CREATE INDEX i_vocabulary_user_id ON vocabulary  (
  user_id pg_catalog.int8_ops ASC 
);
CREATE INDEX i_vocabulary_words_id ON vocabulary  (
  words_id pg_catalog.int8_ops ASC 
);

-- ----------------------------
-- Primary Key structure for table vocabulary
-- ----------------------------
ALTER TABLE vocabulary ADD CONSTRAINT vocabulary_pkey PRIMARY KEY (id);

-- ----------------------------
-- Indexes structure for table words
-- ----------------------------
CREATE INDEX i_words_spelling ON words  (
  spelling  pg_catalog.text_ops ASC 
);

-- ----------------------------
-- Primary Key structure for table words
-- ----------------------------
ALTER TABLE words ADD CONSTRAINT words_pkey PRIMARY KEY (id);

ALTER TABLE "public"."user_password" ADD CONSTRAINT "user_password_pkey" PRIMARY KEY ("id");