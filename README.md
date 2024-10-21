
 Real-Time Sensor Data Monitoring App

This project is a desktop application developed in C# that displays real-time data from various sensors such as temperature, gas, and humidity. The data is continuously updated and visualized in the app using data collected from an ESP32 microcontroller, which is responsible for acquiring sensor readings.

 Features:
- Real-time data display: The application fetches and displays temperature, gas concentration, and humidity levels in real time.
- Firebase integration: The sensor data is stored and retrieved from Firebase, ensuring secure and efficient cloud storage and real-time synchronization.
- ESP32 as a data acquisition device: The ESP32 microcontroller reads the sensor values and sends the data to Firebase.
- User-friendly interface: The application provides a clean and intuitive interface for monitoring sensor data, suitable for both casual users and professionals.

 Technology Stack:
- C#: Used for building the desktop application.
- Firebase: Cloud database used for storing and retrieving sensor data.
- ESP32: Microcontroller used for data acquisition from the sensors (temperature, gas, humidity).

 How It Works:
1. The ESP32 reads data from the sensors.
2. Sensor data is sent to Firebase in real-time.
3. The desktop application retrieves the data from Firebase and displays it in real-time for the user to monitor.

 Future Enhancements:
- Integration of additional sensors for a broader range of data monitoring.
- Historical data visualization and trend analysis.
- Alerts and notifications for abnormal sensor values.


