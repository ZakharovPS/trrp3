package com.zakharov.users.controller;

import com.zakharov.users.UserProto;
import com.zakharov.users.service.UserService;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping(path = "/users")
public class UserController {

    private final UserService userService;

    public UserController(UserService userService) {
        this.userService = userService;
    }

    @PostMapping()
    public ResponseEntity<?> create(@RequestBody UserProto.User user) {
        return new ResponseEntity<>(userService.create(user), HttpStatus.CREATED);
    }


    @GetMapping()
    public ResponseEntity<?> read() {
        return new ResponseEntity<>(userService.readAll(), HttpStatus.OK);
    }

    @PutMapping(value = "/{id}")
    public ResponseEntity<?> update(@PathVariable(name = "id") int id, @RequestBody UserProto.User user) {
        if (userService.update(user, id))
            return new ResponseEntity<>(HttpStatus.OK);
        else
            return new ResponseEntity<>(HttpStatus.NOT_MODIFIED);
    }

    @DeleteMapping(value = "/{id}")
    public ResponseEntity<?> delete(@PathVariable(name = "id") int id) {
        if (userService.delete(id))
            return new ResponseEntity<>(HttpStatus.OK);
        else
            return new ResponseEntity<>(HttpStatus.NOT_MODIFIED);
    }
}
