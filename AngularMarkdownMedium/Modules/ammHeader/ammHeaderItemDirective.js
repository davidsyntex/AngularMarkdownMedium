"use strict";
angular.module("ammHeader")
    .directive("ammHeaderItem",
        function () {
            return {
                require: "^ammHeader",
                scope: {
                    label:"@",
                    route:"@"
                },
                templateUrl: "Modules/ammHeader/ammHeaderItemTemplate.html",
                link: function (scope, el, attr, ctrl) {
                    el.on("click",
                        function(evt) {
                            evt.stopPropagation();
                            evt.preventDefault();
                            scope.$apply(function() {
                                ctrl.setActiveElement(el);
                                ctrl.setRoute(scope.route);

                            });
                        });
                }

            };
        });