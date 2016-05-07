ko.bindingHandlers.datepicker = {
    init: function (element, valueAccessor, allBindingsAccessor) {
        debugger;        //initialize datepicker with some optional options
        var options = allBindingsAccessor().datepickerOptions || {};
        var dateFormat = allBindingsAccessor().dateFormat;
        if (!dateFormat) {
            options.dateFormat = 'dd.mm.yyyy';
        }
        $(element).datepicker(options);
    }
};

function RegisterController() {

    var self = this;

    ko.validation.rules.pattern.message = 'Invalid.';

    self.user = new RegisterUserModel();

    self.validate = function () {
        if (!self.user.isValid()) {
            var errors = ko.validation.group(self.user);
            errors.showAllMessages();

            return false;
        }

        return true;
    };

    self.hasAllValues = ko.computed(function () {
        var val = self.user.isValid();
        return val;
    });
    return this;
};


ko.applyBindings(new RegisterController());
