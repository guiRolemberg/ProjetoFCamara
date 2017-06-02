'use strict';
(function (app) {
    var loginController = function ($scope, $location, authService) {
        $scope.loginData = {
            UserName: "",
            Password: ""
        };

        $scope.message = "";

        $scope.login = function () {

            authService.login($scope.loginData).then(function (response) {

                $location.path('/filmes');

            },
                function (err) {
                    $scope.message = err.error_description;
                });
        };
    };
    app.controller("loginController", loginController);
}(angular.module("AngularAuthApp")));