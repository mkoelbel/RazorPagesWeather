document.addEventListener("DOMContentLoaded", function () {
    const form = document.querySelector("#weather-form");
    const input = document.querySelector("#city-input");
    const resultDiv = document.querySelector("#weather-result");

    form.addEventListener("submit", async function (event) {
        event.preventDefault();

        const city = input.value;

        try {
            const response = await fetch(`/api/weather/${city}`);
            const data = await response.json();

            // Process the weather data and update the UI
            resultDiv.innerText = `Weather in ${city}: ${data.basicdescription}, Temperature: ${data.temperature}°F`;
        } catch (error) {
            console.error("Failed to fetch weather data:", error);
        }
    });
});
