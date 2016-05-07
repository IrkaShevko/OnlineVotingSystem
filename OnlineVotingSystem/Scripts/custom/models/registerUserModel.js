function RegisterUserModel() {
    var self = this;

    self.Email = ko.observable("").extend({ required: true, minLength: 2, maxLength: 40, email: true });
    self.Password = ko.observable("").extend({ required: true, minLength: 6 });
    self.ConfirmPassword = ko.observable("").extend({ required: true, equal: self.Password });
    self.BirthDate = ko.observable().extend({ required: true });

    self.isValid = function () {
        return self.Email.isValid() && self.Password.isValid() && self.ConfirmPassword.isValid() && self.BirthDate.isValid();
    };


    return self;
};