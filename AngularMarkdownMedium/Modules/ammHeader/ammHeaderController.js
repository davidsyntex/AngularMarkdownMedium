"use strict";
angular.module("ammHeader")
    .controller("ammHeaderController",
    [
        "$scope", "$rootScope", function ($scope, $rootScope) {
            this.setActiveElement = function(el) {
                $scope.activeElement = el;
            };
            this.setRoute = function(route) {
                $rootScope.$broadcast("amm-header-item-selected-event",
                { route: route });
            };
        }
    ]);