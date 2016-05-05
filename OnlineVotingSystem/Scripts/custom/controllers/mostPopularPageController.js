function MostPopularPageController() {
    var self = this;

    self.isAscendingVotingName = true;
    self.isAscendingUserName = true;
    self.isAscendingVoicesCount = true;
    self.isAscendingCommentsCount = true;

    self.votings = ko.observableArray([{ name: "Voting1", userName: "Ivan", voicesCount: 3, commentsCount: 4 }, { name: "Voting2", userName: "John", voicesCount: 5, commentsCount: 1 }]);

    self.sortVotingNames = function (voting1, voting2) {
        return 1 == (voting1.name).localeCompare(voting2.name);
    };
    self.reverseSortVotingNames = function (voting1, voting2) {
        return !self.sortVotingNames(voting1, voting2);
    };

    self.sortUserNames = function (voting1, voting2) {
        return 1 == (voting1.userName).localeCompare(voting2.userName);
    };
    self.reverseSortUserNames = function (voting1, voting2) {
        return !self.sortUserNames(voting1, voting2);
    };

    self.sortVoicesCount = function (voting1, voting2) {
        return voting1.voicesCount > voting2.voicesCount;
    };
    self.reverseSortVoicesCount = function (voting1, voting2) {
        return !self.sortVoicesCount(voting1, voting2);
    };

    self.sortCommentsCount = function (voting1, voting2) {
        return voting1.commentsCount > voting2.commentsCount;
    };
    self.reverseSortCommensCount = function (voting1, voting2) {
        return !self.sortCommentsCount(voting1, voting2);
    };

    self.sortTableBy = function (row) {
        switch (row) {
            case 'name': self.isAscendingVotingName ? self.votings.sort(self.sortVotingNames) : self.votings.sort(self.reverseSortVotingNames);
                self.isAscendingVotingName = !self.isAscendingVotingName; break;
            case 'user': self.isAscendingUserName ? self.votings.sort(self.sortUserNames) : self.votings.sort(self.reverseSortUserNames);
                self.isAscendingUserName = !self.isAscendingUserName; break;
            case 'voices': self.isAscendingVoicesCount ? self.votings.sort(self.sortVoicesCount) : self.votings.sort(self.reverseSortVoicesCount);
                self.isAscendingVoicesCount = !self.isAscendingVoicesCount; break;
            case 'comments': self.isAscendingCommentsCount ? self.votings.sort(self.sortCommentsCount) : self.votings.sort(self.reverseSortCommensCount);
                self.isAscendingCommentsCount = !self.isAscendingCommentsCount; break;
            default: break;
        }
    };
}

ko.applyBindings(new MostPopularPageController());