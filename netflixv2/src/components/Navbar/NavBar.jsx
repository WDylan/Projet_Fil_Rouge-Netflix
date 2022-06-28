import "./NavBar.scss"
import SearchIcon from '@mui/icons-material/Search';
import NotificationsIcon from '@mui/icons-material/Notifications';
import ArrowDropDownIcon from '@mui/icons-material/ArrowDropDown';

const NavBar = () => {
  return (
    <div className="navbar">
      <div className="container">
        <div className="left">
          <img src='./img/logo.png' />
          <span>Accueil</span>
          <span>Serie</span>
          <span>Films</span>
          <span>Nouveau et Populaire </span>
          <span>Ma Liste</span>
        </div>
        <div className="right">

          <SearchIcon className="icon" />

          <span>KID</span>

          <NotificationsIcon className="icon" />

          <img src='./img/Netflix-avatar.png' />

          <div className="profile">

            <ArrowDropDownIcon className="icon" />

            <div className="options">
              <span>Options</span>
              <span>Deconnexion</span>
            </div>

          </div>

        </div>

      </div>
    </div>
  )
}

export default NavBar
