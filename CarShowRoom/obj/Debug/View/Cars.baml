   M S B A M L   `   `   `  ����F  BCarShowRoom, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CarShowRoom.ViewModelCarShowRoom.ViewModel  5      5clr-namespace:CarShowRoom.ModelCarShowRoom.Model  5      )clr-namespace:CarShowRoomCarShowRoom  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	          CarShowRoom.View.Cars   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2vm#clr-namespace:CarShowRoom.ViewModel     5      1modelclr-namespace:CarShowRoom.Model     5      +localclr-namespace:CarShowRoom     5      7core&clr-namespace:System;assembly=mscorlib     5	      $��Stretch=�5      $��Stretch=�6#     N� Title$
  Cars��5      $��587.5��6    � 	Resources 5      )  #CarShowRoom.ViewModel.CarsViewModel   carsViewModel  CarShowRoom.DefaultLists 	 lists��%:   &	        &	        5   
   6     5   
   6   5      .��5      � .+�5   
   �� $
��Auto=�6   $��Stretch=�6:   .��5      � $��Stretch=�6   $	��Top=�61   $
��Auto��6I   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��carGrid��5      $��1��6*      CanUserAddRows .    AutoGenerateColumns .  $
��Left=�6i   $��5q�6   ��6�   ��  �� Source# [   �� NotifyOnSourceUpdated .  �� Path$ 
GetListCar� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�	   Columns	 5      4  .System.Windows.Controls.DataGridComboBoxColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
  ��61      TextBinding 6;   �� $ UsedOrNewCar�   ItemsSource 6f   �� # [ $ ListUsedOrNewCar�  5      $ 
 Производитель��61    6H   �� $ ProductionCar� 6s   �� # [ $ ListProduction�0  *System.Windows.Controls.DataGridTextColumn  5      $
 
Марка��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� $ MarkCar�  5      $
 Модель��6-    6=   �� $ ModelCar�  5      $
 
Кузов��61    6@   �� $ BodyTypeCar� 6i   �� # [ $ ListBodyType�  5      $
 Год��6-    6:   �� $ YearCar�  5      $
 Цена��6-    6;   �� $ PriceCar�  5      $
 Область��61    6B   �� $ 	RegionCar� 6i   �� # [ $ 
ListRegion�  5       $
 
Город��6-    6<   �� $ CityCar�  5!      $#
 Обьем двигателя��6-    6F   �� $ EngineAmountCar�  5"      $
 Трансмиссия��61    6F   �� $ TransmissionCar� 6s   �� # [ $ ListTransmission�  5#      $
 Топливо��61    6B   �� $ FuelCar� 6g   �� # [ $ ListFuelType�  5$      $
 Состояние��61    6D   �� $ StateCar� 6k   �� # [ $ 	ListState�5&      5'      5(      5)      5*      