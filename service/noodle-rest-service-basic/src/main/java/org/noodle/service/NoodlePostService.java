package org.noodle.service;

import org.noodle.beans.NoodleException;
import org.noodle.beans.NoodleRequest;

public interface NoodlePostService<T extends NoodleRequest, R> {
    Class<T> getRequestClass();

    R execute(T request) throws NoodleException;
}
