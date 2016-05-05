function RegisterController() {

    ko.validation.rules.pattern.message = 'Invalid.';
    
    var self = this;
    self.Email = ko.observable("").extend({ required: true, minLength: 2, maxLength: 40, email: true });
    self.Password = ko.observable("").extend({ required: true, minLength: 6 });
    self.ConfirmPassword = ko.observable("").extend({ required: true, equal: self.Password });
    self.BirthDate = ko.observable('01/01/2016').extend({ required: true });
    self.message = ko.observable('');

    self.isValid = function () {
        var val = self.BirthDate() === '';
        return self.Email.isValid() && self.Password.isValid() && self.ConfirmPassword.isValid()&&val;
    };

    self.validate = function () {
        if (!self.isValid()) {
            var errors = ko.validation.group(self);
            errors.showAllMessages();

            return false;
        }

        return true;
    };
    self.hasAllValues = ko.computed(function () {
        var val = self.isValid();
        return val;
    });
    return self;
}
    var rc = new RegisterController();
    ko.applyBindings(ko.validatedObservable(rc));


//ko.applyBindings(rc);

//ko.validation.configure({
//    decorateElement: true
//});


ko.validatedObservable = function (initialValue) {
    if (!exports.utils.isObject(initialValue)) {
        return ko.observable(initialValue).extend({ validatable: true });
    }

    var obsv = ko.observable(initialValue);
    obsv.errors = exports.group(initialValue);
    obsv.isValid = ko.computed(function () {
        return obsv.errors().length === 0;
    });

    return obsv;
};
ko.bindingHandlers.datepicker = {
    init: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
        debugger;
        var dateFormat = allBindings().dateFormat;
        var buttonImage = allBindings().buttonImage; // allBindings.get('dateFormat');

        if (typeof dateFormat == 'undefined') {
            dateFormat = 'mm/dd/yyyy';
        }

        var options = {
            showOtherMonths: true,
            selectOtherMonths: true,
            dateFormat: dateFormat,
            buttonImage: buttonImage,
            showOn: "both"
        };

        if (typeof valueAccessor() === 'object') {
            $.extend(options, valueAccessor());
        }

        $(element).datetimepicker(options);
    },

    update: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
        debugger;
        var v = valueAccessor()();
        bindingContext.$data.message(v);
    }

};

