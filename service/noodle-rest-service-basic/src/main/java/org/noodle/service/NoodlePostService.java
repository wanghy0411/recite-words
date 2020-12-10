package org.noodle.service;

import org.noodle.beans.NoodleException;
import org.noodle.beans.NoodleApiParam;

public interface NoodlePostService {
    Object execute(NoodleApiParam request) throws NoodleException;
}
