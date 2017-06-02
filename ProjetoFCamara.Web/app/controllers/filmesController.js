'use strict';
(function (app) {
    var filmesController = function ($scope, filmesService) {
        $scope.filmes = [];

        filmesService.getFilmes().then(function (results) {
            $scope.filmes = results.data;
        }, function (error) {
            alert(error.data.message);
        });        
    };
    app.controller("filmesController", filmesController);
}(angular.module("AngularAuthApp")));