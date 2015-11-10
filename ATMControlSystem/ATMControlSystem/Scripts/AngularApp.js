var AngularApp = angular.module('AngularApp', ['ngRoute']);

AngularApp.controller('WithdrawController', WithdrawController);

AngularApp.factory('AuthHttpResponseInterceptor', AuthHttpResponseInterceptor);
AngularApp.factory('WithdrawFactory', WithdrawFactory);

var configFunction = function ($routeProvider, $httpProvider) {
    $routeProvider.
        when('/withdraw', {
            templateUrl: 'withdrawal/withdraw',
            controller: 'WithdrawController'
        })
        
    $httpProvider.interceptors.push('AuthHttpResponseInterceptor');
        
}
configFunction.$inject = ['$routeProvider', '$httpProvider'];

AngularApp.config(configFunction);