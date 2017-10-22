(function (angular) {
  'use strict'
  angular.module('PersonManagementApp', ['smart-table'])
    .controller("PersonManagementCtrl", ['$scope', function ($scope) {
      $scope.rowCollection = [
        { firstName: 'Laurent', lastName: 'Renard', birthDate: new Date('1987-05-21'), balance: 102, email: 'whatever@gmail.com' },
        { firstName: 'Blandine', lastName: 'Faivre', birthDate: new Date('1987-04-25'), balance: -2323.22, email: 'oufblandou@gmail.com' },
        { firstName: 'Francoise', lastName: 'Frere', birthDate: new Date('1955-08-27'), balance: 42343, email: 'raymondef@gmail.com' }
      ];

      $scope.deleteItem = function deleteItem (row) {
        var index = $scope.rowCollection.indexOf(row);
        if (index !== -1) {
          $scope.rowCollection.splice(index, 1);
        }
      }

      $scope.editItem = function editItem (row) {
        var index = $scope.rowCollection.indexOf(row)
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