(function (app) {
    var TestImageListController = function ($scope, $http) {
        $http.get("/api/ImagesForTests").success(function (data) {
            $scope.ImagesForTests = data;
        });
    };
    app.controller("TestImageListController", TestImageListController);
}(angular.module("TestImages")));
