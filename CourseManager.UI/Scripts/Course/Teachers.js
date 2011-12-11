Teachers = function (config) {
  $.extend(this, config);
  this.init();
}

$.extend(Teachers, {
  init: function () {
    $('addTeacherDialog').dialog({
      autoOpen: false,
      modal: false
    })
  },

  attachAddTeacher: function () {
    var that = this;
    $('#add-teacher').click(function () {
      $('addTeacherDialog').load(that.addTeacherViewUrl);
      $('addTeacherDialog').dialog('open');

    });

  }
});