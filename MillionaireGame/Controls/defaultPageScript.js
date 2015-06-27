$(document).ready(function () {

    /* help region vizualization */
    $('#help_50_50').hover(
        function () {
            $('#help_50_50').attr("src", "images/help_50_50_.png");
        },
        function () {
            $('#help_50_50').attr("src", "images/help_50_50.png");
        }
    );
    $('#help_room').hover(
        function () {
            $('#help_room').attr("src", "images/help_room_.png");
        },
        function () {
            $('#help_room').attr("src", "images/help_room.png");
        }
    );
    $('#help_call').hover(
        function () {
            $('#help_call').attr("src", "images/help_call_.png");
        },
        function () {
            $('#help_call').attr("src", "images/help_call.png");
        }
    );

    
    /*change color text and region color when hover mouse cursor*/

    var actionAnswerHover = function($imageButton, $titleAnswer, $textAnswer) {
        $imageButton.hover(function() {
            $imageButton.attr('src', 'images/answer_hover.jpg');
            $titleAnswer.css('color', 'white');
            $textAnswer.css('color', 'black');
        }, function() {
            $imageButton.attr('src', 'images/answer.jpg');
            $titleAnswer.css('color', '#FFB000');
            $textAnswer.css('color', 'white');
        });

        var imitationImageButtonHover = function($varInitImitation) {
            $varInitImitation.hover(function() {
                $imageButton.trigger('mouseover');
            }, function() {
                $imageButton.trigger('mouseout');
            });

            $varInitImitation.click(function() {
                $imageButton.trigger('click');
            });
        }

        imitationImageButtonHover($titleAnswer);
        imitationImageButtonHover($textAnswer);
    }

    actionAnswerHover($('#imageButtonA'), $('#titleAnswerA'), $('#lblAnswerA'));
    actionAnswerHover($('#imageButtonB'), $('#titleAnswerB'), $('#lblAnswerB'));
    actionAnswerHover($('#imageButtonC'), $('#titleAnswerC'), $('#lblAnswerC'));
    actionAnswerHover($('#imageButtonD'), $('#titleAnswerD'), $('#lblAnswerD'));
});