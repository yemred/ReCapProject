﻿using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac
{
    public class ValidationAspect : MethodInterception  //Aspect
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            //
            // defensive coding. Aşşağıdaki if kodunu yazmasakta çalışır fakat, attribute lar typeof ile çalıştığı için
            // Gönderdiğin validatorTpe ın IValıdator mü demektir. Kullanıcı bambaşka classlar yollamasın diye yapıyoruz. Buda defensive code diyoruz
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değildir");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            // Reflection Kodu alt satır.Yani çalışma anında İnstance oluşturmadır. 
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
