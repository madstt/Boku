/*!
*  Hest
*/

jQuery(document).ready(function () {
    jQuery( 'a.submenu_link' ).hover( function( i ) {
        jQuery( 'a.submenu_link' ).parent().removeClass( 'open' );
        jQuery( this ).parent().addClass( 'open' );
    });
    jQuery( 'li.menupop' ).hover( function(){}, function(){
        jQuery( this ).removeClass( 'open' );
    });
});     