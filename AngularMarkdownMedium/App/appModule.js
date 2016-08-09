"use strict";
angular.module("app", ["ngRoute", "ammContainer"]);

/*var app = angular.module("amm", ["ngSanitize"]);

app.controller("postsController",["$scope","$http",function($scope, $http) {
    $scope.posts;
    $scope.post;
    $scope.getAllPosts = GetAllPosts();
    $scope.convertMarkdownToHtml = ConvertMarkdownToHtml();

    function ConvertMarkdownToHtml(data) {
        var converter = new showdown.Converter();
        converter.setOption("tables", "true");
        return converter.makeHtml(data);
    }

    function GetAllPosts() {
        $http.get("/api/posts").success(function(data, header, status, config) {
            $scope.posts = data;
            for (var i = 0; i < $scope.posts.length; i++) {
                $scope.posts[i].Content=ConvertMarkdownToHtml($scope.posts[i].Content);

            }
        }).error(function(data, header, status, config) {
            alert("Sumting wong!");
        });
    }

    function GetAllPostsByAuthor(authorToLookFor) {
        $http.get("/api/posts/author/", { params: { authorToLookFor } }).success(function (data, header, status, config) {
            $scope.posts = data;
        }).error(function (data, header, status, config) {
            alert("Sumting wong!");
        });
    }
}]);*/