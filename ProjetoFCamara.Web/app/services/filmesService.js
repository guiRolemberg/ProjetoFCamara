'use strict';
(function (app) {
    var filmesService = function ($http) {
        var serviceBase = 'http://localhost:58814/';
        var filmesServiceFactory = {};

        var _getFilmes = function () {

            return $http.get(serviceBase + 'api/filmes').then(function (results) {
                return results;
            });
        };

        filmesServiceFactory.getFilmes = _getFilmes;

        return filmesServiceFactory;
    };
    app.service("filmesService", filmesService);
}(angular.module("AngularAuthApp")));