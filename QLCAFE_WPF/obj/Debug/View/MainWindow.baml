   M S B A M L   `   `   `  ����E  AQLCAFE_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:QLCAFE_WPF.ViewmodelQLCAFE_WPF.Viewmodel  5   
        QLCAFE_WPF.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   
   .local"clr-namespace:QLCAFE_WPF.Viewmodel  5   
   ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowState$ 	Maximized=�5   	   $	��806��5	   	   $	��500��5
   	    � Title$ 
MainWindow��5   	   $	��500��6   $��1126.267��6)    � 	Resources 5      %   QLCAFE_WPF.Viewmodel.intToColor   con �� 
TargetType �� Property �� Value��%~   &	        '��        5   
   6   �� 5   
   " ��6   texttab1��.�5      ��  � ��$
 Bold"�6+   5      5       � DataContext 5      (  "QLCAFE_WPF.Viewmodel.MainViewModel  5   
   -   5        ds��5      .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
   	   	EventName$	 Closed��6   .  (System.Windows.Interactivity.TriggerBase
   Actions.
 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *close+   CommandParameter 5   $   ��  �� ElementName$ FloatingPasswordBox��5      .��5      ]� .+�5   
   o� $	��Top=�6   .@�5      m� $
��File��6   .@�5       m� $��_Save��6   5!      m� 5"      $
��File��6   .@�5#      m� $��_Save��6   5$      m� 5%      $
��File��6   .@�5&      m� $��_Save��6   5'      5(      � 5)   
   .+�5*      �� .@�5+      �� $
��Bàn��6   ���	#FFE5E5E5.��5,      � ���	#FFE5E5E5.+�5.      �  � ColumnDefinitions 5/      �� 50   "   �� 51   "   $	��300 �63   .+�54      �� $��0��6'   $��0��67   $��Stretch=�6E   $��Stretch=�6a   $��Disabled=�6�   $
��Auto=�6�   ��.  � UseLayoutRounding .  ��6   �� *TbF+��55   "   �� 56   &   .R�57   *   ��  �� Orientation$ Vertical=�65   .+�59   .   �� $��50��6�   $��50��6�   ��65   �� *name+��6N   �� *status+ �� 	Converter# [  ��5:      �� *DataContext.Clickbutton+ �� RelativeSource ��  �� AncestorType" �� �� Mode$ FindAncestor=���5;      �� *status+5=   +   5>   '   ��5@   "   �� 5A   &   .R�5B   *   � 5C   '   5E      � 5G      $��1��6#   
������� � RowDefinitions 5H   "   �� 5I   &   $	��130 �64   �� 5J   &   �� 5K   &   $	��100 �64   .+�5M   "   � $��0��6'    5N   &   �� 5O   *   $��70 �6;   �� 5P   *   �� 5Q   *   $��62 �6;    5S   &   �� 5T   *   �� 5U   *   �� 5V   *   �� 5W   *   .+�5Y   &   �� $��0��60   $��0��6@   $��Chọn loại: ��6M   $��Center=�6`   $��Right=�6{   $��16��6�   $��0,8,0,9q�6�   $��53��6�   �� 5Z   &   $��0��60   $��1��6@   $��Chọn món: ��6M   $��Center=�6_   $��Right=�6z   $��16��6�   $	��0,9q�6�   $��58��6�   �� 5[   &   $��0��60   $��2��6@   $��Số lượng: ��6M   $��Center=�6_   $��Right=�6z   $��16��6�   $��0,9,0,8q�6�   $��50��6�   �� 5\   &   $��0��60   $��3��6@   $��Tên bàn: ��6M   $��Center=�6^   $��Right=�6y   $��16��6�   $��0,9,0,8q�6�   $��50��6�   �� 5]   &   -   5        $��
cbCategory��5]   /   $��1��6A   $��0��6Q   $	��5,4q�6^    �� DisplayMemberPath$
 name��6�    �� SelectedValuePath$ id��6�   ��6k   �� *NhomTA+ 5^   *     5_   .   $	 SelectionChanged��6=   .
 5`   2      6H   �� *selectioonChanged_cbCategory+ 6y   �� $ 
cbCategory��5b   /   5d   '   �� 5e   &   -   5        $��cbMon��5e   /   $��1��6<   $��1��6L   $��5q�6Y   $
 name��6�   $ id��6�   ��6d   �� *Food+ �� Mode$ TwoWay=�6�   %  DevExpress.Xpf.Editors.SpinEdit  5g   &   $��1��63   $��2��6C   $	��5,4q�6P   '  !DevExpress.Xpf.Editors.ButtonEdit   IsTextEditable$
 TrueX�6]       AllowRoundOutOfRangeValue .    MinValue$ 1X�6�      MaxValue$ 99999999999X�6�   %	  DevExpress.Xpf.Editors.BaseEdit 	  
IsReadOnly .  %
  DevExpress.Xpf.Editors.TextEdit 
  Mask$ n0��6�    
  MaskCulture$ vi-VN��6�   �� 5h   &   $��1��6.   $��3��6>   $	��5,4q�6K   �� 5i   &   $��2��6-   $��Thêm��6=   $	��4,2q�6L   $��1��6Y   5j   #   �� 5k   "   $��1��6+   $��0,0,-9,0q�68   $��Danh sách món��6J   .��5l   &   � .+�5m   &   �� -   5        $��lvUsers��5m   /   $��5 0 0 0q�6>     �� View  5n   *   �� 5o   .   .P�5p   2   �� $
��Name��6A   ! �� DisplayMemberBinding! 6P   �� *Name+�� 5q   2   $	��Age��6A   ! 6O   �� *Age+�� 5r   2   $
��Mail��6A   ! 6P   �� *Mail+5s   /   5v   +   5w   #   5x   #   �� 5y   "   $��2��6+   $��0,0,-9,0q�68   .��5z   "   � .+�5{   &   �� $��10,10,200,43q�60   �� 6G   $�Tổng tiền��6K   6_   �� 5|   &   $�� ��6.   $��92,10,10,43q�66   �� 5~   &   $��Thanh toán��6-   $��
98,41,82,7q�6B   5   #   5�   #   5�      5�      5�      5�      �� 5�      $��Admin��6   .��5�      �� $ Vertical=�6!   ���	#FFE5E5E5$��0,-5,0,5q�6O   .+�5�      �� ���	#FFE5E5E5 6<   �� *Ac+.+�5�      �� $��fdfdf��6(   �� 5�      ��6(   �� *id+�� 5�      ��6(   �� *
UserName+" �� UpdateSourceTrigger$" PropertyChanged=�5�      �� 5�      �� 6%   $	�123��6)   �� 66   $� ��6:   �� 6E   .F�5�   
   �� $	��120��6   ��6   �� *Obs+# �� SelectedValue# 6;   �� *Ac+��5�      �� 5�      .R�5�      � $ � Orientation$$ 
Horizontal=�6   .+�5�      �� 
����� ���6'   �� *id+5�      5�      5�      5�   
   �� 6   $� ��6!   �� 6,   .F�5�   
   �� $	��200��6   $	��282��6    ��6,   �� *Obs+% �� SelectedItem% 6H   �� *SelectedItem+$ OneWayToSource=���5�      �� 5�      .R�5�      �� $ Vertical=�6   .+�5�      �� $��50��6f   $��50��6q   ��6   �� *id+��6,   �� *id+# [  ��5�      �� *DataContext.Clickbutton+ �� " ��$ FindAncestor=���5�      �� *id+5�      5�      ��5�      �� 5�      .R�5�      � & K� IsItemsHost& . $$ 
Horizontal=�6*   5�      5�      5�   
   6   5�      5�      5�      5�      5�      5�      