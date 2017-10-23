(function (angular) {
  'use strict'
  angular.module('PersonManagementApp', ['smart-table'])
    .controller('PersonManagementCtrl', ['$scope', function ($scope) {
      $scope.rowCollection = [
        { name: 'Laurent Renard', dob: '1987-05-21', email: 'whatever@gmail.com' },
        { name: 'Blandine Faivre', dob: '1987-04-25', email: 'oufblandou@gmail.com' },
        { name: 'Francoise Frere', dob: '1955-08-27', email: 'raymondef@gmail.com' }
      ]

      $scope.currentItem = {}

      $scope.deleteItem = function deleteItem (row) {
        var index = $scope.rowCollection.indexOf(row)
        if (index !== -1) {
          $scope.rowCollection.splice(index, 1)
        }
      }

      $scope.editItem = function editItem (row) {
        var index = $scope.rowCollection.indexOf(row)
        $scope.currentItem = row
        if (index !== -1) {
          $('#myModal').modal('show')
        }
      }

      $scope.detailItem = function detailItem (row) {
        var index = $scope.rowCollection.indexOf(row)
        if (index !== -1) {
          $('#myModal').modal('show')
        }
      }
    }])
})(window.angular)
