function MyVotingsPageController() {
    var self = this;

    self.isAscendingVotingName = true;
    self.isAscendingVoicesCount = true;
    self.isAscendingCommentsCount = true;
    self.isAscendingStartDate = true;
    self.isAscendingEndDate = true;

    self.votings = ko.observableArray([{ name: "Voting1", voicesCount: 3, commentsCount: 4, startDate: "12:12:2005", endDate: "12:12:2007" }, { name: "Voting2", voicesCount: 5, commentsCount: 1, startDate: "12:12:2015", endDate: "12:12:2017"}]);

    self.sortVotingNames = function (voting1, voting2) {
        return 1 == (voting1.name).localeCompare(voting2.name);
    };
    self.reverseSortVotingNames = function (voting1, voting2) {
        return !self.sortVotingNames(voting1, voting2);
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

    self.sortStartDate = function (voting1, voting2) {
        return 1 == (voting1.startDate).localeCompare(voting2.startDate);
    };
    self.reverseSortStartDate = function (voting1, voting2) {
        return !self.sortStartDate(voting1, voting2);
    };

    self.sortEndDate = function (voting1, voting2) {
        return 1 == (voting1.endDate).localeCompare(voting2.endDate);
    };
    self.reverseSortEndDate = function (voting1, voting2) {
        return !self.sortEndDate(voting1, voting2);
    };

    self.sortTableBy = function (row) {
        switch (row) {
            case 'name': self.isAscendingVotingName ? self.votings.sort(self.sortVotingNames) : self.votings.sort(self.reverseSortVotingNames);
                self.isAscendingVotingName = !self.isAscendingVotingName; break;
           case 'voices': self.isAscendingVoicesCount ? self.votings.sort(self.sortVoicesCount) : self.votings.sort(self.reverseSortVoicesCount);
                self.isAscendingVoicesCount = !self.isAscendingVoicesCount; break;
            case 'comments': self.isAscendingCommentsCount ? self.votings.sort(self.sortCommentsCount) : self.votings.sort(self.reverseSortCommensCount);
                self.isAscendingCommentsCount = !self.isAscendingCommentsCount; break;
            case 'start': self.isAscendingStartDate ? self.votings.sort(self.sortStartDate) : self.votings.sort(self.reverseSortStartDate);
                self.isAscendingStartDate = !self.isAscendingStartDate; break;
            case 'end': self.isAscendingEndDate ? self.votings.sort(self.sortEndDate) : self.votings.sort(self.reverseSortEndDate);
                self.isAscendingEndDate = !self.isAscendingEndDate; break;
           default: break;
        }
    };
}

ko.applyBindings(new MyVotingsPageController());