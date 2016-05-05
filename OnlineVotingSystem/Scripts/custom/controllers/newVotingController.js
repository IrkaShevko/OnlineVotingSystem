function NewVotingController() {
    var self = this;
    
    self.MAX_COUNT_OF_VARIANTS = 10;
    self.MIN_COUNT_OF_VARIANTS = 1;
    
    self.variants = ko.observableArray([{ id: 0, text: 'first' }, { id: 1, text: 'second' }]);

    self.id  = 1;
    self.addNewVariant  = function() {
        self.variants.push({id: self.id++,text: ''});
    }
    //self.addNewVariant = function() {
    //    self.variants.push('variant' + (self.variants().length+1));
    //};
    self.deleteVariant = function (index) {
        self.variants.splice(index, 1);
    };
    self.saveVoting = function () {
        window.location.href = '/Home/Index';
    }
}

ko.applyBindings(new NewVotingController());