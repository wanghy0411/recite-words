package org.noodle.bean.dictionary.select;

/**
 * 公用字典搜索服务返回信息
 * @author wanghy
 */
public class DictionarySearchPublicDto {
    private Long id;

    /**
     * 字典名
     */
    private String name;

    /**
     * 出版社
     */
    private String publisher;

    /**
     * 已选定
     */
    private Boolean selected;

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getPublisher() {
        return publisher;
    }

    public void setPublisher(String publisher) {
        this.publisher = publisher;
    }

    public Boolean getSelected() {
        return selected;
    }

    public void setSelected(Boolean selected) {
        this.selected = selected;
    }
}
