"use strict";
angular.module("ammHeader")
    .directive("ammHeader",
        function() {
            return {
                scope: {},
                transclude: true,
                templateUrl: "Modules/ammHeader/ammHeaderTemplate.html",
                controller: "ammHeaderController",
                link: function(scope, el, attr) {

                }

            };
        });