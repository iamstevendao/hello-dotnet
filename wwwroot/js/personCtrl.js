(function (angular) {
  'use strict'
  angular.module('PersonManagementApp', ['smart-table'])
    .controller('PersonManagementCtrl', ['$scope', function ($scope) {
      $scope.rowCollection = [
        { name: 'Laurent Renard', dob: new Date(1987, 5, 21), email: 'whatever@gmail.com' },
        { name: 'Blandine Faivre', dob: new Date(1987, 5, 21), email: 'oufblandou@gmail.com' },
        { name: 'Francoise Frere', dob: new Date(1987, 5, 21), email: 'raymondef@gmail.com' }
      ]

      $scope.currentItem = {}
      let index = -1

      $scope.reset = function () {
        $scope.clone = angular.copy($scope.currentItem)
      }

      $scope.deleteItem = function (row) {
        getCurrentItem(row)
        if (index !== -1) {
          $scope.rowCollection.splice(index, 1)
        }
      }

      $scope.editItem = function (row) {
        getCurrentItem(row)
        $scope.reset()
        $('#myModal').modal('show')
      }

      $scope.detailItem = function (row) {
        getCurrentItem(row)
        if (index !== -1) {
          $('#myModal').modal('show')
        }
      }

      function getCurrentItem (row) {
        index = $scope.rowCollection.indexOf(row)
        $scope.currentItem = row
      }

      $scope.update = function () {
        $scope.rowCollection[index] = $scope.clone
        $('#myModal').modal('hide')
      }
    }])
})(window.angular)
