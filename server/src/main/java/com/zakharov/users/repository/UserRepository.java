package com.zakharov.users.repository;

import com.zakharov.users.model.UserPOJO;
import org.springframework.data.jpa.repository.JpaRepository;

public interface UserRepository extends JpaRepository<UserPOJO, Integer> { }