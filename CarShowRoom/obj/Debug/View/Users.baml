   M S B A M L   `   `   `  ����F  BCarShowRoom, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CarShowRoomCarShowRoom  5      =#clr-namespace:CarShowRoom.ViewModelCarShowRoom.ViewModel  5          CarShowRoom.View.Users   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:CarShowRoom     5      2vm#clr-namespace:CarShowRoom.ViewModel     5      $��Stretch=�5	      $��Stretch=�6$     N� Title$  Users��5
       � 	Resources 5      )  #CarShowRoom.ViewModel.UserViewModel   userViewModel  CarShowRoom.DefaultLists 	 lists��%:   &	        &	        5   
   6     5   
   6   5      .��5      � .+�5   
   �� $
��Auto=�6   $��Stretch=�6:   .��5      � $
��Left=�6   $
��Auto��6.   $
��auto��6;   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��userGrid��5         AutoGenerateColumns .  $��Stretch=�6G   $	��500��6e   $
��Auto��6r   $	��Top=�6   $��5q�64  ��6�   ��  �� Source# [   �� NotifyOnSourceUpdated .  �� Path$ GetListUser� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Телефон��6-   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6>   �� $ Phone�4  .System.Windows.Controls.DataGridComboBoxColumn  5      $	  ��61      TextBinding 6;   �� $ UsedOrNewUser�   ItemsSource 6g   �� # [ $ ListUsedOrNewCarAll�  5      $ 	 Производитель��61    6H   �� $ ProductionUser� 6u   �� # [ $ ListProductionAll�  5      $	 
Марка��6-   
 6<   �� $ MarkUser�  5      $	 Модель��6-   
 6=   �� $ 	ModelUser�  5      $	 
Кузов��61    6@   �� $ BodyTypeUser� 6k   �� # [ $ ListBodyTypeAll�  5      $	 Год от��6-   
 6=   �� $ YearMinUser�  5      $	 Год до��6-   
 6=   �� $ YearMaxUser�  5      $	 Цена от��6-   
 6>   �� $ PriceMinUser�  5      $	 Цена до��6-   
 6>   �� $ PriceMaxUser�  5      $	 Область��61    6B   �� $ 
RegionUser� 6k   �� # [ $ ListRegionAll�  5      $	 
Город��6-   
 6<   �� $ CityUser�  5       $(	 "Обьем двигателя от��6-   
 6I   �� $ EngineAmountMinUser�  5!      $(	 "Обьем двигателя до��6-   
 6I   �� $ EngineAmountMaxUser�  5"      $	 Трансмиссия��61    6F   �� $ TransmissionUser� 6u   �� # [ $ ListTransmissionAll�  5#      $	 Топливо��61    6B   �� $ FuelUser� 6i   �� # [ $ ListFuelTypeAll�  5$      $	 Состояние��61    6D   �� $ 	StateUser� 6l   �� # [ $ ListStateAll�4  .System.Windows.Controls.DataGridTemplateColumn  5%         CellTemplate 5&      �� 5'   "   .R�5(   &   �� -   5        $��Подобрать��5(   -    � DataContext$  ��6V   5)   #   5+      5-      5.      5/      50      51      