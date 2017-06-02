﻿'use strict';
(function (app) {
    var indexController = function ($scope, $location, authService) {
        $scope.logOut = function () {
            authService.logOut();
            $location.path('/home');
        }
        $scope.authentication = authService.authentication;
    };
    app.controller("indexController", indexController);
}(angular.module("AngularAuthApp")));