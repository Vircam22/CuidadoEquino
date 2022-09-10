// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function(){

    const toggle = $("#header-toggle"),
    nav = $("#nav-bar"),
    bodypd = $("#body-pd"),
    headerpd = $("#header");

    toggle.on("click", function() {
        // show navbar
        nav.toggleClass('show');
        //nav.classList.toggle('show');
        // change icon
        toggle.toggleClass('bx-x');
        //toggle.classList.toggle('bx-x');
        // add padding to body
        bodypd.toggleClass('body-pd');
        //bodypd.classList.toggle('body-pd');
        // add padding to header
        headerpd.toggleClass('body-pd');
        // headerpd.classList.toggle('body-pd');
    });
    
    /*===== LINK ACTIVE =====*/
    const linkColor = document.querySelectorAll('.nav_link')

    function colorLink() {
        if (linkColor) {
            linkColor.forEach(l => l.classList.remove('active'))
            this.classList.add('active')
        }
    }
    linkColor.forEach(l => l.addEventListener('click', colorLink))

    // Your code to run since DOM is loaded and ready
});