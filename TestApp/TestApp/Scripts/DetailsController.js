(function (app) {
    var DetailsController = function ($scope, $http, $routeParams) {
        var id = $routeParams.id;
        $http.get("/api/ImagesForTests/" + id)
            .success(function (data) {
                $scope.ImagesForTest = data;
            });
    };
    app.controller("DetailsController", DetailsController);
}(angular.module("TestImages")));
