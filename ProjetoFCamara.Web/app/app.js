(function () {
    var app = angular.module('AngularAuthApp', ['ngRoute', 'LocalStorageModule']);

    app.config(function ($routeProvider) {
        $routeProvider
            .when("/home",
            {
                controller: "homeController",
                templateUrl: "/app/views/home.html"
            })
            .when("/login",
            {
                controller: "loginController",
                templateUrl: "/app/views/login.html"
            })
            .when("/signup", {
                controller: "registrarController",
                templateUrl: "/app/views/registrar.html"
            })
            .when("/filmes", {
                controller: "filmesController",
                templateUrl: "/app/views/filmes.html"
            })
            .otherwise({ redirectTo: "/home" });
    });
    app.config(function ($httpProvider) {
        $httpProvider.interceptors.push('authInterceptorService');
    });
    app.run(['authService', function (authService) {
        authService.fillAuthData();
    }]);
}());