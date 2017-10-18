(function (angular) {
  'use strict'
  angular.module('PersonManagementApp', ['smart-table'])
    .controller("PersonManagementCtrl", ['$scope', function ($scope) {
      $scope.rowCollection = []
      
    }])
})(window.angular)