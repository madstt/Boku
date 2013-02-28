$(document).ready(function () {

    var subMenuMargins = new Array();
    subMenuMargins[0] = "0px";
    subMenuMargins[1] = "5px";
    subMenuMargins[2] = "5px";
    subMenuMargins[3] = "35px";
    subMenuMargins[4] = "250px";
    subMenuMargins[5] = "510px";
    subMenuMargins[6] = "200px";
    subMenuMargins[7] = "0px";
    subMenuMargins[8] = "100px";


    var id = $("#selected-menu-tab").attr('id');
    id = id.split('-');
    id = id[2];
    $("#header #global-submenu ul").css('margin-left', subMenuMargins[id - 1]);

    $("#header #global-menu li").hover(
	  function () {
	      $('#header #global-menu ul li.active').removeClass('active').addClass('inactive');
	      $('#header #global-menu #active-left-corner').remove();
	      $('#header #global-menu #active-right-corner').remove();

	      $(this).removeClass('inactive');
	      $(this).addClass('active');
	      $(this).append('<div id="active-left-corner"></div><div id="active-right-corner"></div>');
	      var id = $(this).attr('id');
	      id = id.split('-');
	      id = id[2];
	      var submenu = 'global-submenu-' + id;
	      $("#header #global-submenu").html($("#header #" + submenu).html());
	      //$("#header #global-submenu ul").css('margin-left',subMenuMargins[id-1]);
	  },
	  function () {
	      var hovered_li = $(this);

	      $("#header #global-menu-topspace").hover(function () {


	          hovered_li.removeClass('active').addClass('inactive');
	          $('#header #global-menu #active-left-corner').remove();
	          $('#header #global-menu #active-right-corner').remove();


	          var old_tab = $("#header #selected-menu-tab").html();
	          $("#" + old_tab).removeClass('inactive');
	          $("#" + old_tab).addClass('active');
	          $("#" + old_tab).append('<div id="active-left-corner"></div><div id="active-right-corner"></div>');

	          $("#header #global-submenu").html($("#global-default-submenu").html());


	      }, function () { })


	      $("#header #global-submenu").hover(function () { }, function () {

	          /*

			  hovered_li.removeClass('active').addClass('inactive');
			  $('#header #global-menu #active-left-corner').remove();
			  $('#header #global-menu #active-right-corner').remove();
			  
			  
			  var old_tab = $("#header #selected-menu-tab").html();
			  $("#" + old_tab).removeClass('inactive');
			  $("#" + old_tab).addClass('active');
			  $("#" + old_tab).append('<div id="active-left-corner"></div><div id="active-right-corner"></div>');		
			  
			  
			  $("#header #global-submenu").html($("#global-default-submenu").html());
			  
			  */
	      })

	  }
	 );

    var on_menu = false;

    $("#choose-country").hover(function () {

        //$("#gh-arrow").html('<img src="http://www.jamieoliver.com/test-global-nav/images/down-point-arrow.jpg" />');

        //Following events are applied to the subnav itself (moving subnav up and down)  
        $("#gh-dropdown").slideDown('slow').show(); //Drop down the subnav on click  

        $("#gh-dropdown").parent().hover(function () {
        }, function () {
            //$("#gh-dropdown").slideUp('slow', function () { $("#gh-arrow").html('<img src="http://www.jamieoliver.com/test-global-nav/images/arrow.jpg" />'); });
        });


    },
	function () {



	});

});