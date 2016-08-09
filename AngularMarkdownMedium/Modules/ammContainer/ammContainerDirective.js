"use strict";
angular.module("ammContainer").directive("ammContainer", function () {
    return {
        transclude: true,
        scope: {
        
        },
        controller: "ammContainerController",
        templateUrl: "Modules/ammContainer/ammContainerTemplate.html"
    };
})