   M S B A M L   `   `   `  ����E  AQLCAFE_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:QLCAFE_WPF.ViewmodelQLCAFE_WPF.Viewmodel  5   	       QLCAFE_WPF.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   4local"clr-namespace:QLCAFE_WPF.Viewmodel     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   -   5          �Name$  Vlogin��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � Title$ Login��5	   	   $��171.429��6   $��439.85��6(    � DataContext 5
      )  #QLCAFE_WPF.Viewmodel.LoginViewModel  5   
   6!   .��5      � $��10q�6    � 	Resources 5   
    �� 
TargetType �� Property �� Value��%�   '��       �� 5      " ��6   .�5      ��  � ��$
 Bold"�6/   �� 5       � ��$ tahoma)�6/   �� 5       � ��$
 13px(�6-   5      5      	 � ColumnDefinitions	 5   
   �� 5      $	��100 �6   �� 5      
 � RowDefinitions
 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��Tên đăng nhập:��6   $��0��6*   $��0��67   $��Center=�6G   $��Right=�6b   $
��Bold"�6~   �� 5    
   $��Mật khẩu:��6   $��1��6%   $��0��62   $��Center=�6B   $��Right=�6]   �� 5!   
   $��0��6   $��1��6   $
��5,10q�6/   $��Stretch=�6=   $��0q�6u   ��6[   �� *
UserName+6u   G� 5"   
   -   5        $��FloatingPasswordBox��5"      $��1��62   $��1��6?   $
��5,10q�6O   $��5q�6]   $��Center=�6i   .  (System.Windows.Interactivity.Interaction   Triggers 5#      /  )System.Windows.Interactivity.EventTrigger  5$         	EventName$ PasswordChanged��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5%      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *PasswordChangedCommand+   CommandParameter 5&   $   ��  �� ElementName$ FloatingPasswordBox��5'      5*      � 5+   
   $��2��6   $��2��6   	 5,      �� 5-      �� 5.      .+�50      �� $��0��6   $��Đăng nhập��6%   $��Center=�69   $��5q�6T   $��Center=�6`   $	��100��6}   
���������6�   �� *login+��51      �� $ Vlogin��52      �� 53      $��1��6   $��Huỷ��6%   $��Center=�63   $��5q�6N   $��Center=�6Z   $	��100��6w   ��6�   �� *close+54      55      56      