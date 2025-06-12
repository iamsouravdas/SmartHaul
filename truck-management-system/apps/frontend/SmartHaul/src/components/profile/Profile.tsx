import React from 'react'
import type { ImageProps } from './profile.type'
import "./profile.styles.css"


const Profile: React.FC<ImageProps> = (props) => {
  return (
    <div className="d-flex me-2 mt-1">
        {/* <p className= "pt-sans-regular mt-2 me-1">{props.name}</p> */}
      <img className= "profile-image" src={props.image} alt="profile image"></img>
    </div>
  )
}

export default Profile
