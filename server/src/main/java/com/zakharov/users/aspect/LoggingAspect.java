package com.zakharov.users.aspect;

import java.util.Arrays;

import org.aspectj.lang.JoinPoint;
import org.aspectj.lang.ProceedingJoinPoint;
import org.aspectj.lang.annotation.*;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.stereotype.Component;

@Aspect
@Component
public class LoggingAspect {

    private final Logger logger = LoggerFactory.getLogger(this.getClass());

    @Pointcut("within(com.zakharov.users..*)")
    public void applicationPackagePointcut() {
    }

    @Before("applicationPackagePointcut()")
    public void logBefore(JoinPoint joinPoint) {
        logger.info("Enter in method {}.{}() with arguments {}", joinPoint.getSignature().getDeclaringTypeName(),
                joinPoint.getSignature().getName(), Arrays.toString(joinPoint.getArgs()));
    }

    @AfterReturning(pointcut = "applicationPackagePointcut()", returning = "result")
    public void logAfter(JoinPoint joinPoint, Object result) {
        logger.info("Method {}.{}() return value {}", joinPoint.getSignature().getDeclaringTypeName(),
                joinPoint.getSignature().getName(), result);
    }

    @AfterThrowing(pointcut = "applicationPackagePointcut()", throwing = "exception")
    public void logAfterThrowing(JoinPoint joinPoint, Throwable exception) {
        logger.error("Method {}.{}() throw exception {}", joinPoint.getSignature().getDeclaringTypeName(),
                joinPoint.getSignature().getName(), exception);
    }
}
