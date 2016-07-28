(function () {
    var app = angular.module("TestImages", ["ngRoute"]);
    var config = function ($routeProvider) {
        $routeProvider
        .when("/home",
            { templateUrl: "/View/Index.html", controller: "TestImageListController" })
        .when("/details/:id",
            { templateUrl: "/View/details.html", controller: "DetailsController" })
        .otherwise(
            { redirectTo: "/home", controller: "TestImageListController" });
    };

    app.config(config);
}());
