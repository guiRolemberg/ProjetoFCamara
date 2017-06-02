'use strict';
(function (app) {
    var authService = function ($http, $q, localStorageService) {
        var serviceBase = 'http://localhost:58814/';
        var authServiceFactory = {};

        var _authentication = {
            isAuth: false,
            UserName: ""
        };

        var _saveRegistration = function (registration) {

            _logOut();

            return $http.post(serviceBase + 'api/conta/registrar', registration).then(function (response) {
                return response;
            });

        };

        var _login = function (loginData) {

            var data = "grant_type=password&UserName=" + loginData.UserName + "&Password=" + loginData.Password;

            var deferred = $q.defer();
            
            $http.post(serviceBase + 'token', data, { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } })
                .then(function (response) {
                    localStorageService.set('authorizationData', { token: response.access_token, UserName: loginData.UserName });
                    _authentication.isAuth = true;
                    _authentication.UserName = loginData.UserName;
                    deferred.resolve(response);
                }
                , function errorCallback(response) {
                    _logOut();
                    deferred.reject(response);                
                });
            return deferred.promise;
        };
        var _logOut = function () {

            localStorageService.remove('authorizationData');

            _authentication.isAuth = false;
            _authentication.UserName = "";

        };
        var _fillAuthData = function () {

            var authData = localStorageService.get('authorizationData');
            if (authData) {
                _authentication.isAuth = true;
                _authentication.UserName = authData.UserName;
            }

        };
        authServiceFactory.saveRegistration = _saveRegistration;
        authServiceFactory.login = _login;
        authServiceFactory.logOut = _logOut;
        authServiceFactory.fillAuthData = _fillAuthData;
        authServiceFactory.authentication = _authentication;

        return authServiceFactory;
    };
    app.service("authService", authService);
}(angular.module("AngularAuthApp")));