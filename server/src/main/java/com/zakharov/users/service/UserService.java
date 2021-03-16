package com.zakharov.users.service;

import com.zakharov.users.UserProto;
import com.zakharov.users.model.UserPOJO;

import java.util.List;

public interface UserService {
    UserProto.User create(UserProto.User user);
    UserProto.ListUsers readAll();
    boolean update(UserProto.User user, int id);
    boolean delete(int id);
}
