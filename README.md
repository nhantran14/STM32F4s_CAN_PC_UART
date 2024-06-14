There is 2 data flows. One is that User sends ADC command through GUI to STM32F4 Master by UART, then Master sends the command to Slave by CAN protocol. Slave then reads ADC values and responds 
them to Master by CAN. These values are displayed in GUI.
The other flow is that User sends DAC command. Slave then through Master writes DAC values out.
