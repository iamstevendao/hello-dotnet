(function (angular) {
  'use strict'
  angular.module('PersonManagementApp', ['smart-table'])
    .controller('PersonManagementCtrl', ['$scope', function ($scope) {
      $scope.rowCollection = []
      $scope.currentItem = {}
      let index = -1

      $.ajax({
        url: '/api/Person/List',
        type: 'POST',
        success: function (response) {
          $scope.rowCollection = formatResponse(response)
          $scope.$apply()
        },
        error: function (e) {
          console.log(e)
        }
      })

      function formatResponse (response) {
        response.map((value) => { value.dob = new Date(value.dob) })
        return response
      }

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

      function getCurrentItem (row) {
        index = $scope.rowCollection.indexOf(row)
        $scope.currentItem = row
      }

      $scope.update = function () {
        $scope.rowCollection[index] = $scope.clone
        let person = {
          ID: $scope.clone.id,
          Name: $scope.clone.name,
          Dob: $scope.clone.dob,
          Address: $scope.clone.address
        }
        $.ajax({
          url: '/api/Person/Edit/' + person.ID,
          type: 'POST',
          data: person,
          success: function (response) {
            console.log(response);
          },
          error: function (e) {
            console.log(e)
          }
        })
        $('#myModal').modal('hide')
      }
    }])
})(window.angular)
