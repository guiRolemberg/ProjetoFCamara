'use strict';
(function (app) {
    var registrarController = function ($scope, $location, $timeout, authService) {
        $scope.savedSuccessfully = false;
        $scope.message = "";

        $scope.registration = {
            UserName: "",
            Password: "",
            ConfirmPassword: ""
        };

        $scope.signup = function () {
            authService.saveRegistration($scope.registration)
                .then(function (response) {
                    $scope.savedSuccessfully = true;
                    $scope.message = "Registrado com sucesso, você será direcionado para página de login em 2 segundos.";
                    startTimer();
                }), function (error) {
                    var errors = [];
                    for (var key in error.data.modelState) {
                        for (var i = 0; i < response.data.modelState[key].length; i++) {
                            errors.push(error.data.modelState[key][i]);
                        }
                    }
                    $scope.message = "Falha ao registrar-se:" + errors.join(' ');
                };                
        };
        var startTimer = function () {
            var timer = $timeout(function () {
                $timeout.cancel(timer);
                $location.path('/login');
            }, 2000);
        };
    };    
    app.controller("registrarController", registrarController);
}(angular.module("AngularAuthApp")));