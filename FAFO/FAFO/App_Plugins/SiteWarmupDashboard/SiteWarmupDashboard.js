angular.module("umbraco").controller("siteWarmupDashboardController", function ($scope) {
    var vm = this;

    $scope.loadFrames = false;
    $scope.loading = false;

    $scope.getPages = function () {

        console.log('getPages started');

        $scope.loading = true;

        //angular.element(document).ready(function () { });

        $.get('/umbraco/backoffice/api/SiteWarmupApi/GetPages')
            .then(function (result) {
                console.log('getPages data returned');
                var d = result;
                $scope.pages = d;
                $scope.loading = false;
                $scope.$apply();
                console.log('getPages complete');
            });

    }

    $scope.pages = [];

});