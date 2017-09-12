﻿using MyApp.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Domain.Commands
{
    public class RegisterNewUserCommand : UserCommand
    {
        public RegisterNewUserCommand(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }

        public override bool IsValid()
        {
            var validationResult = new RegisterNewUserCommandValidation().Validate(this);
            return validationResult.IsValid;
        }
    }
}
