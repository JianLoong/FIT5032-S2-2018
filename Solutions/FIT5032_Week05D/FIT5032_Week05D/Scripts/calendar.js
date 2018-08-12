var events = [];

$(".events").each(function () {
    var title = $(".title", this).text().trim();
    var start = $(".start", this).text().trim();

    var event = {
        "title": title,
        "start": start
    };

    events.push(event);
});

$("#calendar").fullCalendar({
    locale: 'au',
    events: events,

    dayClick: function (date, allDay, jsEvent, view) {
        var d = new Date(date);
        var m = moment(d).format("YYYY-MM-DD");
        m = encodeURIComponent(m);
        var uri = "/Events/Create?date=" + m;
        $(location).attr('href', uri);
    }
});