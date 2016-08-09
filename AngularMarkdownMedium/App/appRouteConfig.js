"use strict";
angular.module("app")
    .config([
        "$routeProvider", function($routeProvider) {
            var routes = [
                {
                    url: "/home",
                    config: {
                        template: "<amm-home>home</amm-home>"
                    }
                }, {
                    url: "/posts",
                    config: {
                        template: "<amm-posts>posts</amm-posts>"
                    }
                }, {
                    url: "/authors",
                    config: {
                        template: "<amm-authors>authors</amm-authors>"
                    }
                }, {
                    url: "/tags",
                    config: {
                        template: "<amm-tags>tags</amm-tags>"
                    }
                }
            ];
            routes.forEach(function(route) {
                $routeProvider.when(route.url,route.config);
            });
            $routeProvider.otherwise({redirectTo:"/home"});
        }
    ]);