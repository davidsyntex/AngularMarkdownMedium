"use strict";
angular.module("ammContainer")
    .controller("ammContainerController",
    [
        "$scope", function($scope) {
            $scope.$on("amm-header-item-selected-event", function(evt, data) {
                $scope.routeString = data.route;
            });
        }
    ]);