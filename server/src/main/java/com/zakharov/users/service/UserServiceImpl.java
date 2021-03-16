package com.zakharov.users.service;

import com.zakharov.users.UserProto;
import com.zakharov.users.model.UserPOJO;
import com.zakharov.users.repository.UserRepository;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class UserServiceImpl implements UserService {

    private final UserRepository userRepository;

    public UserServiceImpl(UserRepository userRepository) {
        this.userRepository = userRepository;
    }

    private UserPOJO ConvertToUserPOJO(UserProto.User user)
    {
        return new UserPOJO(user.getName(), user.getSurname(), user.getAge(), user.getEmail());
    }

    private UserProto.User ConvertToProtoUser(UserPOJO userPOJO)
    {
        return UserProto.User.newBuilder().setId(userPOJO.getId()).setName(userPOJO.getName()).setSurname(userPOJO.getSurname()).setAge(userPOJO.getAge()).setEmail(userPOJO.getEmail()).build();
    }

    private UserProto.ListUsers ConvertTOProtoListUsers(List<UserPOJO> usersPOJO)
    {
        List<UserProto.User> users = new ArrayList<UserProto.User>();
        for (UserPOJO userPOJO : usersPOJO)
            users.add(UserProto.User.newBuilder().setId(userPOJO.getId()).setName(userPOJO.getName()).setSurname(userPOJO.getSurname()).setAge(userPOJO.getAge()).setEmail(userPOJO.getEmail()).build());
        return UserProto.ListUsers.newBuilder().addAllUsers(users).build();
    }

    @Override
    public UserProto.User create(UserProto.User user) {
        return ConvertToProtoUser(userRepository.save(ConvertToUserPOJO(user)));
    }

    @Override
    public UserProto.ListUsers readAll() {
        return ConvertTOProtoListUsers(userRepository.findAll());
    }


    @Override
    public boolean update(UserProto.User user, int id) {
        UserPOJO userPOJO = ConvertToUserPOJO(user);
        if (userRepository.existsById(id)) {
            userPOJO.setId(id);
            userRepository.save(userPOJO);
            return true;
        }
        return false;
    }

    @Override
    public boolean delete(int id) {
        if (userRepository.existsById(id)) {
            userRepository.deleteById(id);
            return true;
        }
        return false;
    }
}